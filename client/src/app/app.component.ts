import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'client';
  weatherForecast: any;

  constructor(private http: HttpClient) {
    
  }
  ngOnInit(): void {
    this.http.get('http://localhost:5170/weatherforecast').subscribe(
      response => { this.weatherForecast = response; },
      error => { console.log(error) }
    );
  }
}
