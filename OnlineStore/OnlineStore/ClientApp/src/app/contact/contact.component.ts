  import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ContactService } from '../services/contactService';

@Component({
  selector: 'll-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.scss']
})
export class ContactComponent implements OnInit {

  frmContact: FormGroup;

  constructor(public fb: FormBuilder, public contactService: ContactService, private snackBar: MatSnackBar) {
  }

  ngOnInit(): void {
    this.frmContact = this.fb.group({
      'ContactId': new FormControl(''),
      'Name': new FormControl('', Validators.required),
      'Phone': new FormControl('', Validators.required),
      'Email': new FormControl('', Validators.required),
      'Subject': new FormControl('', Validators.required),
      'Message': new FormControl('', Validators.required),
    });
  }

  SaveContact() {
    this.contactService.SaveContact({
      ContactId: 0,
      Name: this.frmContact.controls['Name'].value,
      Phone: this.frmContact.controls['Phone'].value,
      Email: this.frmContact.controls['Email'].value,
      Subject: this.frmContact.controls['Subject'].value,
      Message: this.frmContact.controls['Message'].value
    }).subscribe(res => {
      this.snackBar.open("Gracias por tus comentarios", "Okay!", {
        duration: 5000,
        horizontalPosition: "center",
        verticalPosition: "bottom",
      });
      this.ClearForm();
    }, (error) => {
      console.log(error.status);
    });
  }

  ClearForm() {
    this.frmContact.controls['ContactId'].setValue(0)
    this.frmContact.controls['Name'].setValue('')
    this.frmContact.controls['Phone'].setValue('')
    this.frmContact.controls['Email'].setValue('')
    this.frmContact.controls['Subject'].setValue('')
    this.frmContact.controls['Message'].setValue('')
  }
}
