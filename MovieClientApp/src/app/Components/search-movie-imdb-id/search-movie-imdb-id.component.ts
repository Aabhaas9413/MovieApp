import { Component } from '@angular/core';
import { SearchService } from 'src/app/Services/search.service';

@Component({
  selector: 'app-search-movie-imdb-id',
  templateUrl: './search-movie-imdb-id.component.html',
  styleUrls: ['./search-movie-imdb-id.component.css']
})
export class SearchMovieImdbIdComponent {
  movieInfo = []
  constructor(private searchService: SearchService) { }

  getMovie(IMDbID: string){
    this.searchService.getMovieByIMDbID(IMDbID).subscribe(movie =>{
      console.log(movie);
      this.movieInfo = movie;     
    })
  }
}
