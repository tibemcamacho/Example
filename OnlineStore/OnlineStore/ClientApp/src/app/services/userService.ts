import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { UserEntity } from "../models/usertEntity";

@Injectable()
export class UserService {
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }
  url = "http://localhost:5010/";
  constructor(private http: HttpClient) { }

  SaveUser(contactEntity: UserEntity): Observable<any> {
    return this.http.post<any>(this.url + 'User/SaveUser', JSON.stringify(contactEntity), this.httpOptions);
  }

  GetUser(email: string, password: string): Observable<UserEntity> {
    return this.http.get<UserEntity>(this.url + 'User/GetUser/' + email + "/" + password);
  }
}
