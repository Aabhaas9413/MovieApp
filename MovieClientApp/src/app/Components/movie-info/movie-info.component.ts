import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-movie-info',
  templateUrl: './movie-info.component.html',
  styleUrls: ['./movie-info.component.css']
})
export class MovieInfoComponent implements OnInit {
  
  movieInfo :any 
  
  ngOnInit(): void {
    this.movieInfo = localStorage.getItem("movie-info");
    this.movieInfo = JSON.parse(this.movieInfo);
  }


}
