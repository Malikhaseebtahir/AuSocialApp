import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ValueService {

  constructor(private http: HttpClient) { }

  getValues() {
    return this.http.get('/api/values');
  }

  getValue(id: number) {
    return this.http.get('/api/values/${id}');
  }
}
