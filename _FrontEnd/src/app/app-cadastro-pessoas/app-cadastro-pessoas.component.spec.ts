/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { AppCadastroPessoasComponent } from './app-cadastro-pessoas.component';

describe('AppCadastroPessoasComponent', () => {
  let component: AppCadastroPessoasComponent;
  let fixture: ComponentFixture<AppCadastroPessoasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AppCadastroPessoasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AppCadastroPessoasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
