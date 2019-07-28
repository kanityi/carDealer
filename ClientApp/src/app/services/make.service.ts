import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MakeService {

  constructor(private http: Http) { }

  getMakes() {
    return this.http.get('api/makes')
      .map(res => res.json());
  }
}
