import {twoNumber} from '数字和日期.js'
// 简单实现类对象之间的继承关系
 function Employee(name){
    this.Name = name||"";  //设置默认值的方式
    this.Age = 18;
}

function Manage(){
    Employee.call(this); //如果没有这行 将不能访问到基类的属性
    this.ManageId= '';
}

var obj1 = {Name:"Hasaki"};
Manage.prototype = Object.create(Employee.prototype);  //没有这行,就不能访问到在运行时,给父类对象指定的原型属性
var manage = new Manage();  //创建对象的方式
var Obj1 = Object.create(obj1);  //创建对象的方式
console.log(manage.Age);

Employee.prototype.EmployeeId = null;  //Employee是基类，给基类的原型添加一个属性,那么所有的子类都能访问到

console.log(Obj1.Name);
console.log(manage.EmployeeId);
console.log(manage.Name);

function abc(){
    console.log("abc") ;
}

function def(){
    console.log("def");
}

console.log(twoNumber);