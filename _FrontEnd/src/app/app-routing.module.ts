import { AppCadastroPessoasComponent } from './app-cadastro-pessoas/app-cadastro-pessoas.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path:'pessoas-cadastro', component:AppCadastroPessoasComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
