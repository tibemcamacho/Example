import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from '../../services/userService';
import { MatSnackBar } from "@angular/material/snack-bar";

@Component({
  selector: 'll-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.scss']
})
export class SignupComponent implements OnInit {
  frmCustomer: FormGroup;
  constructor(public fb: FormBuilder, public userService: UserService, private router: Router, private snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.frmCustomer = this.fb.group({
      'StoreId': new FormControl(''),
      'Name': new FormControl('', Validators.required),
      'LastName': new FormControl('', Validators.required),
      'Email': new FormControl('', Validators.required),
      'Password': new FormControl('', Validators.required),
      'Address': new FormControl('', Validators.required),
    });
  }

  Submit(): void {
    this.userService.SaveUser({
      CustomerId: 0,
      StoreId: 1,
      Name: this.frmCustomer.controls['Name'].value,
      LastName: this.frmCustomer.controls['LastName'].value,
      Email: this.frmCustomer.controls['Email'].value,
      Password: this.frmCustomer.controls['Password'].value,
      Address: this.frmCustomer.controls['Address'].value,
      DateCreation: new Date()
    }).subscribe(res => {
      this.ClearForm();
      this.router.navigate(['/']);
    }, (e) => {
      this.snackBar.open(e.error, "Okay!", {
        duration: 5000,
        horizontalPosition: "center",
        verticalPosition: "bottom",
      });
    });
  }

  ClearForm() {
    this.frmCustomer.controls['Name'].setValue('');
    this.frmCustomer.controls['LastName'].setValue('');
    this.frmCustomer.controls['Email'].setValue('');
    this.frmCustomer.controls['Password'].setValue('');
    this.frmCustomer.controls['Address'].setValue('');
    
  }
}
