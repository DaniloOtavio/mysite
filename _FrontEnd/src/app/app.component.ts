import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']

})
export class AppComponent {
  title = 'mysite';

  rotated = false;

  rotate(): any {
const arrow = document.getElementById('arrow');


    if(this.rotated){
      arrow?.classList.add('rotated');
    }
  }
}
