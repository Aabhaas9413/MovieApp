import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from  '@angular/common/http';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  path: string = environment.baseUrl;
  constructor(private http: HttpClient) { }

  getMovieList(text: string, page: string):Observable<any>{
    return this.http.get(this.path + "getMovieListByTitle/" +  text + '/' + page);
  }
  getMovieByTitle(text: string):Observable<any>{
    return this.http.get(this.path + "getMovieByTitle/" + text);
  }
  getMovieByIMDbID(id: string):Observable<any>{
    return this.http.get(this.path + "getMovieByIMDbId/" +  id);
  }
}
