import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TiposService {

  url: string = 'api/Tipos';

  constructor(private http: HttpClient) { }
}
