import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchMovieListComponent } from './search-movie-list.component';

describe('SearchMovieListComponentComponent', () => {
  let component: SearchMovieListComponent;
  let fixture: ComponentFixture<SearchMovieListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SearchMovieListComponent]
    });
    fixture = TestBed.createComponent(SearchMovieListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
