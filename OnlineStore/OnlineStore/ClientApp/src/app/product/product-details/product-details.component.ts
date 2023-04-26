import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductEntity } from '../../models/productEntity';
import { LocalService } from '../../services/localService ';
import { ProductService } from '../../services/productService';

@Component({
  selector: 'll-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss']
})
export class ProductDetailsComponent implements OnInit {
  productsEntity: ProductEntity;
  idProduct: number;
  constructor(private _route: ActivatedRoute, private _ProductService: ProductService,
    private localStore: LocalService, private router: Router, private snackBar: MatSnackBar) { }
  
  ngOnInit(): void {
    this._route.params.subscribe(params => {
      this.idProduct = params['id']
      this.loadProduct();
    }); 
  }

  loadProduct(): void {
    this._ProductService.GetArticleById(this.idProduct).subscribe((res: ProductEntity) => {
      this.productsEntity = res;
    }, (error) => {
      console.log(error.status);
    });
  }

  OnSubmit() {
    var count = this.localStore.getLength();
    if (count > 0) {
      this._ProductService.SaveArticle(this.idProduct).subscribe(res => {
        this.snackBar.open("Gracias por su compra", "Información!", {
          duration: 5000,
          horizontalPosition: "center",
          verticalPosition: "bottom",
        });
        setTimeout(() => {
          this.router.navigate(['/']);
        }, 5000);
      }, (error) => {
        console.log(error.status);
      });

    } else
      this.router.navigate(['/auth/login/' + this.idProduct]);
  }
}
