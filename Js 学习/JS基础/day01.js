
//#region  Switch 语句
// var testSwitch = "abc";
// switch (testSwitch) {
//     case "a":
//         console.log("我是a");
//         break;
//     case "b":
//         console.log("我是b");
//         break;
//     case "abc":
//         console.log("我是abc");
//         break;
//     default:
//         console.log("什么也不是");
//         brea

// }
//#endregion

//#region  try-catch语句
// const a = 10;
// function doSomethingErrorProne () {
//     if (a+20==30) {
//       throw (new Error('The message'));
//     } else {
//      console.log()
//     }
//   }

// try {

// }

// catch(e){
//     console.log(e);
// }

//#endregion

//#region  对象

// var myCar = {carType:{a:"奥迪","b":"奔驰"},"123":"MyCars"};

// console.log(myCar.carType["b"]);

// var person = new Object();
// person.name = "孙郑浩";
// person.fuc = function(){console.log("abc")};

// person.fuc();

//#endregion

//#region  求某一个对象类型 typeof
// eval只接受一个string类型的值，并且这个string类型的值是一个js的表达式或者语句,如果不是表达式或者语句,就会抛语法错误异常
// var s = "abc";
// console.log(typeof s);
// var res = eval("'2'+'2'");
// console.log(typeof res);
// repeat方法，将指定的str重复指定的次数返回
// console.log("abc".repeat(5));

//#endregion

//#region 多行模板字符串,类似于c# $"{变量}"
// 实现字符串多行显示
// console.log("a b \n c d");
// console.log(`a b
//  c d`)

// //字符串内嵌表达式
// var a = 10;
// var b = 20;
// console.log(`result is ${a + b}`);


//#endregion

//#region 正则表达式

// 创建正则表达式

var re = /a+/;  //如果正则表达式值不会改变,使用此值可能会有更好的效率

// var newRe = new RegExp("a+");
// var reRes = newRe.test("aabc");
// console.log(reRes);


// 断言
// 先行断言 c之后跟 '-'才匹配，如果匹配的到的话是匹配断言前的值
// var judgeStr = "abc--defrrrrrrrc-";
// var re1 = /\w+c(?=-)/;
// console.log(re1.exec(judgeStr)); // exec返回的是一个数组，第一个元素是匹配到的文本内容,第二个元素是匹配到的文本内容,如果能匹配的到的话,以此类推,还有 index属性
// 第一个匹配文本内容的下标，还有group属性,如果没有匹配到内容,exec将会返回null.

// 负向先行断言,匹配断言前的值
// var re2 = /\w+-+\w+e(?!g)/;
// console.log(re2.exec(judgeStr));

// 后行断言,匹配不包括括号内的内容,当然,括号前边匹配的内容包括了括号内的内容
// var re3 = /(?<=b)c-+\w+/;
// console.log(re3.exec(judgeStr));

// 负向后行断言,匹配断言
// var re4 = /\w+(?<!r)c/;
// console.log(re4.exec(judgeStr));
//#endregion

//#region 循环

var list = new Array("a", "b", "c");
// for in 遍历的是可迭代对象的下表
for (var item in list) {
  console.log(item);
}

// for of 遍历的是可迭代对象的内容
for (var item of list) {
  console.log(item);
}

// label标记的作用
  // 作用 标记一个循环,当想在i=5 and j=5,跳出整个循环，这样比较方便
  // 如果单独使用break ,只跳出了内层循环。
var num = 0;
stopAllXunhuan:
for (var i = 0; i < 10; i++) {
  for (var j = 0; j < 10; j++) {
    if (i == 5 && j == 5) {
      break stopAllXunhuan;
    }
    num++;
  }
}
console.log(num);


//#endregion