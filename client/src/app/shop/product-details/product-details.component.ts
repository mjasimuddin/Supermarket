import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IProduct } from 'src/app/shared/models/product';
import { ShopService } from '../shop.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss']
})
export class ProductDetailsComponent implements OnInit {
  product?: IProduct;
  quantity = 1;
  id = 0;
  constructor(private shopService: ShopService , private activatedRoute: ActivatedRoute) { 
    this.id = +this.activatedRoute.snapshot.params['id'];
  }

  ngOnInit(): void {
    // this.bcService.set('@productDetails', ' ');
    this.loadProduct();
  }

  loadProduct() {
    debugger
    this.shopService.getProduct(this.id ).subscribe((response: IProduct) => {
      this.product =  response;
      // this.bcService.set('@productDetails', this.product.name);
    }, error => {
      console.log(error);
    });
  }

  // addItemToBasket() {
  //   this.basketService.addItemToBasket(this.product, this.quantity);
  // }

  incrementQuantity() {
    this.quantity++;
  }

  decrementQuantity() {
    if (this.quantity > 1)
    {
      this.quantity--;
    }
  }
}
