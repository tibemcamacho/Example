import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute, Router } from '@angular/router';
import { LocalService } from '../../services/localService ';
import { UserService } from '../../services/userService';

@Component({
  selector: 'll-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  frmUser: FormGroup;
  idProduct: number;
  constructor(public fb: FormBuilder, private localStore: LocalService, public userService: UserService, private snackBar: MatSnackBar, private router: Router, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.frmUser = this.fb.group({
      'Email': new FormControl('', Validators.required),
      'Password': new FormControl('', Validators.required),
    });
    this.activatedRoute.params.subscribe(params => {
      this.idProduct = params['id']
    }); 
  }

  OnSubmit() {
    this.userService.GetUser(this.frmUser.controls['Email'].value, this.frmUser.controls['Password'].value).subscribe(res => {
      this.localStore.saveData(this.frmUser.controls['Email'].value, JSON.stringify(res));
      this.router.navigate(['/products/' + this.idProduct]);
    }, (error) => {
      this.snackBar.open("Usuario no registrado", "Información!", {
        duration: 5000,
        horizontalPosition: "center",
        verticalPosition: "bottom",
      });
      console.log(error.status);
    });
  }
}
