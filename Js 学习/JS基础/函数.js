
// 1. 声明一个函数

function GetNumber(num) {
    return num + 2;
}
// console.log(GetNumber(3));

// 2. 声明函数表达式

var getNumber = function (num) {
    return num + 1;
}

// console.log(getNumber(5));

//在 js中方法体内该表了整数的值,不会影响到全局,如果改变了一个对象的属性,则会改变这个属性的值.
// 类似于强类型语言的 值类型和引用类型


// 函数表达式很容易把一个函数传递给另一个函数,调用的时候直接把函数表达式的名字传递过去即可。
function map(f, getNumber) {
    return f + getNumber(1);
}

// console.log(map(1,getNumber));



// 3.函数递归

var func = function getNum() {
    // do some thing

}

// 以下三种方式是在函数体内部调用等价的 --暂定--不确定
// func();
// getNum();
// arguments.callee();

// 形成一个简单的递归
//     var x = 10;
//     function loop(n){
//         if(n>=10){
//             return;
//         }
//         console.log(x++);
//         loop(n+1);
//     }

//  console.log(loop(3));

// 4.嵌套函数和函数闭包
//外部函数不能使用内部函数的参数和变量，而内部函数可以访问外部函数的参数和变量

// 对闭包简单的理解


// function addNum(x){
//     function addStr(y){
//         return x*y;
//     }

//     return addStr(x);
// }

// function addNum2(x){
//     function addStr2(y){
//         return x*y;
//     }
//     return addStr2;
// }

// console.log(addNum(2));

// var calladdNum2 = addNum2(2);
// console.log(calladdNum2(2));
// console.log(addNum2(2)(2));


// 5.arguments对象
//一个函数虽然声明的形参只有一个，但是调用可以传入多个.
//可以通过arguments对象+下标访问传入的参数,所以可以在函数定义的时候,不必先去考虑有几个参数
//就可以通过arguments对象访问调用时候传入的参数进行相应的操作。
function returnNumber(num1) {
    var result = "";
    for (var i = 0; i < arguments.length; i++) {
        result += arguments[i];
    }
    return result;
}

console.log(returnNumber("1", "2", "#")); //12#

// 6.函数的默认参数
// 调用的时候可以不传默认参数,当然也可以重新指定默认参数的值
function sum(a, b = 10) {
    return a + b;
}
console.log(sum(12));

