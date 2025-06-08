import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Contribuyente } from '../models/contribuyente.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ContribuyenteService {
  private apiUrl = 'https://localhost:7205/api/contribuyentes'; // Ajusta si tu backend usa otro puerto

  constructor(private http: HttpClient) {}

  getAll(): Observable<Contribuyente[]> {
    return this.http.get<Contribuyente[]>(this.apiUrl);
  }
}
