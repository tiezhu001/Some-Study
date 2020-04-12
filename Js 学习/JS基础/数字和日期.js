// 1.二进制数字
  //二进制数字是以0开头,后边接小写或者大写字母的B，如果后边不是跟0,1会提示undefine
var twoNumber = 0B001;
console.log(twoNumber);

// 2.指数形式
var number3 = 2e6;  // 2*10`6
console.log(number3);

// 3.Number对象的常用属性
var maxValue = Number.MAX_VALUE;
console.log(maxValue);
    // Number对象的常用方法
// 把字符串解析为浮点数.和全局的parseInt用法一直

// console.log(Number.parseInt("2222",10));
// console.log(Number.parseFloat("222.00"));

// 4.整数字面值的方法
var number4 = 123;
console.log(number4.toExponential()); //返回整数的指数形式
console.log(number4.toFixed(10));  //返回整数的小数格式

// 5.数学对象 Math
console.log(Math.PI);
console.log(Math.abs(-100));

// 6.日期对象
var data1 = new Date();
var date2 = new Date(2020,2,12,06,50,33);
console.log(data1);
console.log(Date());
console.log(date2);
console.log(`${data1.getHours()},${data1.toLocaleString(),data1.getUTCDate()}`);


