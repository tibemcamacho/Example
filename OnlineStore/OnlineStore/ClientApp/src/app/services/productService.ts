import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ProductEntity } from "../models/productEntity";

@Injectable()
export class ProductService {
  
  url = "http://localhost:5010/";
  constructor(private http: HttpClient) { }

  GetProductHome(): Observable<ProductEntity[]> {
    return this.http.get<ProductEntity[]>(this.url + 'Catalog/GetArticleHome');
  }

  GetArticleById(id: number): Observable<ProductEntity> {
    return this.http.get<ProductEntity>(this.url + 'Catalog/GetArticleById/' + id);
  }

  GetProduct(): Observable<ProductEntity[]> {
    return this.http.get<ProductEntity[]>(this.url + 'Catalog/GetArticle');
  }

  SaveArticle(id: number): Observable<any> {
    return this.http.get<any>(this.url + 'Catalog/SaveArticle/' + id);
  }
}
