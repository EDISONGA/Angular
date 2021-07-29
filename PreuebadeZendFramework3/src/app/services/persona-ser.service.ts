import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';  
@Injectable({
  providedIn: 'root'
})
export class PersonaSerService {

 private myAppUrl = 'https://localhost:44308/';
 private myApiUrl = 'api/Persona/'


 private myApiUrlM = 'api/MaxTb/'
 private myApisUrl = 'api/Sector/'
 private myApizUrl = 'api/Zona/?idsector='
  constructor( private http: HttpClient) { 

  }

  getlistaAgrupadaXsector(id: number): Observable<any> {
    return this.http.get(this.myAppUrl + this.myApiUrlM +id);
     }
   
  getListaPersonas(): Observable<any> {
 return this.http.get(this.myAppUrl + this.myApiUrlM);
  }

  getListaZona(id: number ): Observable<any> {
    return this.http.get(this.myAppUrl + this.myApizUrl +id );
     }




     getListaSector(): Observable<any> {
      return this.http.get(this.myAppUrl + this.myApisUrl);
       }
  deletePersona(id: number):Observable<any>{
    return this.http.delete(this.myAppUrl + this.myApiUrl + id);
  }
  savePersona(personas: any ):Observable<any> {
    return this.http.post(this.myAppUrl + this.myApiUrl ,personas );
 
  }

  updatePersonas(id: number, persona:any): Observable<any>{

    return this.http.put(this.myAppUrl + this.myApiUrl + id, persona);
  }


} 
