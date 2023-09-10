import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SearchService } from 'src/app/Services/search.service';

@Component({
  selector: 'app-search-movie-list',
  templateUrl: './search-movie-list.component.html',
  styleUrls: ['./search-movie-list.component.css']
})
export class SearchMovieListComponent implements OnInit {
  text = "";
  currentPage : number = 1
  movieList : any = []
  movieInfo : any = {}
  totalCount : number = 0
  noResults : boolean = false
  constructor(private route: ActivatedRoute, 
              private searchService: SearchService, 
              private router: Router) { }

  ngOnInit() {
    // paramMap replaces params in Angular v4+
    this.route.paramMap.subscribe(
      (params: any) => {
        this.text = params.get('text');
        this.searchService.getMovieList(this.text, this.currentPage.toString()).subscribe( res => {
          if(res.response == "True"){
            this.noResults = false
            this.movieList = res?.search;
            this.totalCount = parseInt(res?.totalResults)            
          }else{
            this.noResults = true
          }
          
        })
    })
  }

  displayMovieInfo(movieTitle: string){
    this.searchService.getMovieByTitle(movieTitle).subscribe((movie) =>{
      this.movieInfo = movie;  
      localStorage.setItem("movie-info", JSON.stringify(movie))
      this.router.navigate(["/movie"]);
    })
  }
  onScroll(){
    this.currentPage+=1;
    this.searchService.getMovieList(this.text, this.currentPage.toString()).subscribe( res => {
      this.movieList.push(...res?.search);
    })
  }
}
