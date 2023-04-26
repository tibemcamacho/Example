import { Component, OnInit } from '@angular/core';
import { ProductEntity } from '../../models/productEntity';
import { ProductService } from '../../services/productService';
import { productsDB } from '../../shared/data/products'; 
@Component({
  selector: 'll-home-products',
  templateUrl: './home-products.component.html',
  styleUrls: ['./home-products.component.scss']
})
export class HomeProductsComponent implements OnInit {
  productsEntity: ProductEntity[] = [];
  constructor(private _ProductService: ProductService) { 
    this.loadProduct();
  }

  ngOnInit(): void { }

  loadProduct(): void {
    this._ProductService.GetProductHome().subscribe((res: ProductEntity[]) => {
      this.productsEntity = res;
    }, (error) => {
      console.log(error.status);
    });
  }
}
