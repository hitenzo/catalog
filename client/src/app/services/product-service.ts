
import { Subject } from 'rxjs';
import { Injectable } from '@angular/core';
import { Observable } from "rxjs"
import { RequestsProvider } from './request-provider';
import { Category } from '../viewModels/Category';
import { Product } from '../viewModels/product';

@Injectable({
    providedIn: 'root',
})
export class ProductService {
    constructor(private requests: RequestsProvider) { }

    

    GetByCategory(arg1: Category): Observable<Product[]> {
        return new Observable<Product[]>((observer) => {
            let request = this.requests.get('/' + arg1);
            
            request.subscribe(
                (data: Product[]) => {
                    let return_data = data;
                    observer.next(return_data);
                },
                (err) => {
                    observer.next(err)
                }
            );
        });
    } 

    GetByName(arg1: Category, arg2: string): Observable<Product[]> {
        return new Observable<Product[]>((observer) => {
            let request = this.requests.get('/' + arg1 + '/' + arg2);
            
            request.subscribe(
                (data: Product[]) => {
                    let return_data = data;
                    observer.next(return_data);
                },
                (err) => {
                    observer.next(err)
                }
            );
        });
    } 

 

}