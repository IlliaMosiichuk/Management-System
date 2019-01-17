import { Address } from './address';
import { Total } from './total';
import { Article } from './article';
import { Payment } from './payment';

export class OrderList {
    orders: Order[];
}

export class Order {
    id: number;
    number: string;
    orderDate: string;
    processed: boolean;
    trackingNumber: string;
    reference: string;
    total: Total;
    addresses: Address[];
    articles: Article[];
    payments: Payment[];
}