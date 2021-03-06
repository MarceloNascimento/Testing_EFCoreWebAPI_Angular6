import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { IPersonPhone } from './iperson-phone';
import { PersonPhoneRequest } from './person-phone-request';

@Injectable({
  providedIn: 'root'
})
export class PersonPhoneService {

  public apiURL = 'http://localhost:55689/api/PersonPhone'; //APIM uri + product route

  public httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': '  application/json',
      'Access-Control-Allow-Origin': '*',
      'Access-Control-Allow-Methods': 'GET,POST,OPTIONS,DELETE,PUT',
      'Access-Control-Allow-Credentials': 'true',
      'Ocp-Apim-Subscription-Key': 'aa9ba97d5f6741e29bcad1b0998befb6'
    })

  };

  constructor(private http: HttpClient) { }

  update(personPhoneRequest: PersonPhoneRequest): Observable<Object> {
    console.info('id do service ' + personPhoneRequest);

    return this.http.put(`${this.apiURL}`
      , personPhoneRequest, this.httpOptions);
  }

  get(personId: number, phoneNumber: string): Observable<any> {

    return this.http.get(`${this.apiURL}/${personId}/${phoneNumber}`
      , this.httpOptions).pipe(
        catchError(this.handleError<any[]>('get', []))
      );
  }

  getList(): Observable<any> {

    return this.http.get(`${this.apiURL}`
      , this.httpOptions).pipe(
        catchError(this.handleError<any[]>('getList', []))
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
