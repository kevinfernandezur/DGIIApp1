import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ComprobanteFiscal } from '../models/comprobante.model';

@Injectable({
  providedIn: 'root'
})
export class ComprobanteService {
  private apiUrl = 'https://localhost:7205/api/comprobantes'; 

  constructor(private http: HttpClient) {}

  getAll(): Observable<ComprobanteFiscal[]> {
    return this.http.get<ComprobanteFiscal[]>(this.apiUrl);
  }

  getItbisByRnc(rnc: string): Observable<number> {
    return this.http.get<number>(`${this.apiUrl}/${rnc}/itbis`);
  }

  getByRnc(rnc: string): Observable<ComprobanteFiscal[]> {
    return this.getAll().pipe(
    );
  }
}
