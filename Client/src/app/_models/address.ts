export class Address {
    email: string;
    type: eAddressType;
}

export enum eAddressType {
    Billing,
    Delivery
}