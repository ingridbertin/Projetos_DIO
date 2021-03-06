import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.page.html',
  styleUrls: ['./home.page.css'],
})
export class HomePage implements OnInit {
  searchControl: FormControl;
  constructor() {}

  ngOnInit(): void {
    this.searchControl = new FormControl('', Validators.required);
  }
  doSearch() {
    console.log(this.searchControl.value);
  }
}
