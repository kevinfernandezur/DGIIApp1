import { Component, OnInit } from '@angular/core';
import { Contribuyente } from '../../models/contribuyente.model';
import { ContribuyenteService } from '../../services/contribuyente.service';
import { ComprobanteService } from '../../services/comprobante.service';
import { ComprobanteFiscal } from '../../models/comprobante.model';

@Component({
  selector: 'app-contribuyentes',
  standalone: false,
  templateUrl: './contribuyentes.component.html'
})
export class ContribuyentesComponent implements OnInit {
  contribuyentes: Contribuyente[] = [];
  comprobantes: ComprobanteFiscal[] = [];
  totalItbis: number = 0;
selectedContribuyente: Contribuyente | null = null;

  filtroRnc: string = ''; 


  constructor(
    private contribuyenteService: ContribuyenteService,
    private comprobanteService: ComprobanteService
  ) {}

  ngOnInit(): void {
    this.contribuyenteService.getAll().subscribe(data => {
      this.contribuyentes = data;
    });
  }

  actualizarLista(): void {
  this.contribuyenteService.getAll().subscribe(data => {
    this.contribuyentes = data;
    this.selectedContribuyente = null;
    this.comprobantes = [];
    this.totalItbis = 0;
  });
}


  get contribuyentesFiltrados(): Contribuyente[] {
  return this.contribuyentes.filter(c =>
    c.rncCedula.includes(this.filtroRnc)
  );
}


  verComprobantes(contribuyente: Contribuyente): void {
  if (this.selectedContribuyente?.rncCedula === contribuyente.rncCedula) {
    this.selectedContribuyente = null;
    this.comprobantes = [];
    this.totalItbis = 0;
    return;
  }

  this.selectedContribuyente = contribuyente;

  this.comprobanteService.getAll().subscribe(comps => {
    this.comprobantes = comps.filter(c => c.rncCedula === contribuyente.rncCedula);
  });

  this.comprobanteService.getItbisByRnc(contribuyente.rncCedula).subscribe(total => {
    this.totalItbis = total;
  });
}


}
