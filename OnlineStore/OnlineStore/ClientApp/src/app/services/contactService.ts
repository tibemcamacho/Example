import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ContactEntity } from "./../../../src/app/models/contactEntity";

@Injectable()
export class ContactService {
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }
  url = "http://localhost:5010/";
  constructor(private http: HttpClient) { }

  SaveContact(contactEntity: ContactEntity): Observable<any> {
    return this.http.post<any>(this.url + 'Contact/SaveContact', JSON.stringify(contactEntity), this.httpOptions);
  }
}
