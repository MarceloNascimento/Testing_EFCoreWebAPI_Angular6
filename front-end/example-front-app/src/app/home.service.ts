import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class HomeService {
  public apiURL = 'https://apimindtexbr.azure-api.net/route'; //APIM uri + product route

  public httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': '  application/json',
      'Access-Control-Allow-Origin': '*',
      'Access-Control-Allow-Credentials': 'true',
      'Ocp-Apim-Subscription-Key': 'aa9ba97d5f6741e29bcad1b0998befb6'
    })

  };

  constructor(private http: HttpClient) { }

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

  get(id: number): Observable<any> {

    return this.http.get(`${this.apiURL}/${id}`
      , this.httpOptions);
  }

  getList(): Observable<any> {

    return this.http.get(`${this.apiURL}`
      , this.httpOptions).pipe(
        catchError(this.handleError<any[]>('getList', []))
      );
  }



}
