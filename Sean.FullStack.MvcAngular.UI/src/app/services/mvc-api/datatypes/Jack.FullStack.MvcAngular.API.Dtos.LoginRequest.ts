﻿/** 
 * Auto Generated Code
 * Please do not modify this file manually 
 * Assembly Name: "Jack.FullStack.MvcAngular.API"
 * Source Type: "C:\Users\zhenyu.shi\Documents\GitHub\Jack.FullStack.MvcAngular\Jack.FullStack.MvcAngular.API\bin\Debug\netcoreapp2.1\Jack.FullStack.MvcAngular.API.dll"
 * Generated At: 2018-10-19 16:51:40.961
 */
import { RoleEnum } from '../enums/Jack.FullStack.MvcAngular.API.Dtos.RoleEnum';
export interface LoginRequest {
	UserType?: RoleEnum;
	Id?: string;
	PasswordHash?: string;
}