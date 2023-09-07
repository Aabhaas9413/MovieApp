import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchMovieImdbIdComponent } from './search-movie-imdb-id.component';

describe('SearchMovieImdbIdComponent', () => {
  let component: SearchMovieImdbIdComponent;
  let fixture: ComponentFixture<SearchMovieImdbIdComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SearchMovieImdbIdComponent]
    });
    fixture = TestBed.createComponent(SearchMovieImdbIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
