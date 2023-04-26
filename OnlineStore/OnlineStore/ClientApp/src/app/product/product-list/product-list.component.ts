import { Component, OnInit } from '@angular/core';
import { ProductEntity } from '../../models/productEntity';
import { ProductService } from '../../services/productService';
import { productsDB } from '../../shared/data/products';

@Component({
  selector: 'll-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss']
})
export class ProductListComponent implements OnInit {
  isLoaded: boolean;
  productsEntity: ProductEntity[] = [];
  advanceSearchExpanded: boolean = false;
  products = [];
  constructor(private _ProductService: ProductService) {}

  ngOnInit(): void {
    this.loadProduct();
    //setTimeout(() => {
    //  this.products = productsDB.Product;
    //  this.isLoaded = true
    //}, 8000)
  }

  loadProduct(): void {
    
    this._ProductService.GetProduct().subscribe((res: ProductEntity[]) => {
      this.productsEntity = res;
      this.isLoaded = true;
    }, (error) => {
      this.isLoaded = true;
      console.log(error.status);
    });
  }
}
