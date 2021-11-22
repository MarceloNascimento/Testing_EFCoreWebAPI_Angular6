import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HomeService } from '../home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public persons: any;

  constructor(private _homeService: HomeService
    , private _router: Router) { }

  ngOnInit() {
    this.LoadData();
  }


  LoadData() {


  }

}
