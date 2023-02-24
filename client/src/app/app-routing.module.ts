import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
// import { NotFoundComponent } from './core/not-found/not-found.component';
// import { ServerErrorComponent } from './core/server-error/server-error.component';
// import { TestErrorComponent } from './core/test-error/test-error.component';
import { HomeComponent } from './home/home.component';
import { ProductDetailsComponent } from './shop/product-details/product-details.component';
import { ShopComponent } from './shop/shop.component';


const routes: Routes = [
  {path: '', component: HomeComponent, data: {breadcrumb: 'Home'}},
  {path: 'shop', loadChildren: () => import('./shop/shop.module').then(mod => mod.ShopModule)},

  // {path: 'not-found', component: NotFoundComponent, data: {breadcrumb: 'Not Found'}},
  // {path: 'server-error', component: ServerErrorComponent, data: {breadcrumb: 'Server Error'}},
  // {path: 'test-error', component: TestErrorComponent, data: {breadcrumb: 'Test Errors'}},

  { path: 'account', loadChildren: () => import('./account/account.module').then(mod => mod.AccountModule), data: {breadcrumb: {skip: true }} },
  
  // data: {breadcrumb: 'Shop'}}, // This is lazy loading of module.,
  
  {path: '**', redirectTo: '', pathMatch: 'full'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }