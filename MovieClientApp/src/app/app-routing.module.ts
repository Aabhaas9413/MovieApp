import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Components/home/home.component';
import { SearchMovieListComponent } from './Components/search-movie-list/search-movie-list.component';
import { MovieInfoComponent } from './Components/movie-info/movie-info.component';

const routes: Routes = [
  {path : '', redirectTo : '/home', pathMatch : 'full' },
  { path: 'home', component: HomeComponent},
  { path: 'movie-list/:text', component:SearchMovieListComponent},
  { path: 'movie', component: MovieInfoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
