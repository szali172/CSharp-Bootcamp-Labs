import { InventoryItem } from "./InventoryItem";
import { Mountain } from "./Mountain";
import { Product } from "./Product";


// Mountains
let mountains: Mountain[] = [
    { name: "Kilimanjaro", height: 19341 },
    { name: "Everest", height: 29029 },
    { name: "Denali", height: 20310 }
];


function findNameOfTallestMountain(mountains: Mountain[]) : string {
    let tallestMountain = "";
    let maxHeight = 0;

    for (let mountain of mountains) {
        if (mountain.height > maxHeight) {
            maxHeight = mountain.height;
            tallestMountain = mountain.name;
        }
    }

    return tallestMountain;
}

console.log(findNameOfTallestMountain(mountains));


// Products
let products: Product[] = [
    { name: "Apple", price: 1.99 },
    { name: "Banana", price: 0.50 },
    { name: "Oranges", price: 2.68 }
];


function calcAverageProductPrice(products: Product[]) : number {
    return products.reduce((a: number, b) => {return a + b.price}, 0) / products.length;
}

console.log(calcAverageProductPrice(products));


// Inventory
let inventory: InventoryItem[] = [
    { product: { name: "motor", price: 10.00 }, quantity: 10 },
    { product: { name: "sensor", price: 12.50 }, quantity: 4 },
    { product: { name: "LED", price: 1.00 }, quantity: 20 },
]


function calcInventoryValue(items: InventoryItem[]) : number {
    return items.reduce((a, b) => a + (b.product.price * b.quantity), 0);
}

console.log(calcInventoryValue(inventory));