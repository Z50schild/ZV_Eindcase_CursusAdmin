import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {observable, Observable} from 'rxjs'
import {Cursus} from '../models/Cursus'

@Injectable({
    providedIn: 'root'
})

export class CursusService {
    url = 'http://localshost:44317/Api/Cursus';
    constructor(private http: HttpClient){}
    getCursus(): Observable<Cursus[]> {
        return this.http.get<Cursus[]>(this.url)
    }
}