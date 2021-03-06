import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Person } from '../models/person';
import { Observable, of } from 'rxjs';
import { catchError,} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class PersonService {

constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string ) { }


getData(): Observable<Person[]>{

  return this.http.get(this.baseUrl + "PersonDetails")
  .pipe(
    catchError(this.handleError<any>('getData'))
  );
}

private handleError<T>(operation = 'operation', result?: T) {
  return (error: any): Observable<T> => {
    // TODO: send the error to remote logging infrastructure
    console.error(error); // log to console instead

    // TODO: better job of transforming error for user consumption
    console.log(`${operation} failed: ${error.message}`);

    // Let the app keep running by returning an empty result.
    return of(result as T);
  };
}
}
