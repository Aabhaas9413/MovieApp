import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { SearchService } from 'src/app/Services/search.service';

@Component({
  selector: 'app-search-movie',
  templateUrl: './search-movie.component.html',
  styleUrls: ['./search-movie.component.css']
})
export class SearchMovieComponent {
  movieInfo = []
  constructor(private searchService: SearchService, private router:Router) { }

  getMovie(title: string){
    this.searchService.getMovieByTitle(title).subscribe(movie =>{
      this.movieInfo = movie;  
      localStorage.setItem("movie-info", JSON.stringify(movie))
      this.router.navigate(["/movie"]);
    })
  }
}
