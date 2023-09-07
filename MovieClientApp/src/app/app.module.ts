import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { InfiniteScrollModule } from "ngx-infinite-scroll";
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from  '@angular/common/http';

import { AppComponent } from './app.component';
import { SearchMovieListComponent } from './Components/SearchMovieListCard/search-movie-list.component';
import { SearchMovieComponent } from './Components/search-movie/search-movie.component';
import { HomeComponent } from './Components/home/home.component';
import { SearchMovieImdbIdComponent } from './Components/search-movie-imdb-id/search-movie-imdb-id.component';
import { FormsModule } from '@angular/forms';
import { MovieInfoComponent } from './Components/movie-info/movie-info.component';

@NgModule({
  declarations: [
    AppComponent,
    SearchMovieListComponent,
    SearchMovieComponent,
    HomeComponent,
    SearchMovieImdbIdComponent,
    MovieInfoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    InfiniteScrollModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
