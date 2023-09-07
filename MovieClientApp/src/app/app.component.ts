import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MovieClientApp';
  inputValue:string = "";
  private _router : Router;
/**
 *
 */
constructor(private router: Router) {
this._router = router;

}
 getMovieList(text:string){
    this._router.navigate(
      ['/movie-list', text]
  ); 
  }
}
