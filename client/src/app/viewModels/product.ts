import { Category } from "./category";

export class Product {
    id: number;
    category: Category; 
    name: string;
    description: string; 
    price: number;
    
    constructor(dataSource: string) {
        let parsed = JSON.parse(dataSource);

        this.id = parsed.id;
        this.category = parsed.category; 
        this.name = parsed.name; 
        this.description = parsed.description;
        this.price = parsed.price;
    }
}