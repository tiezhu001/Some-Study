// 1.解构
var foo = ["abc", "def", "ghi"];

var foo1 = foo[0];
var foo2 = foo[1];
var foo3 = foo[3];

var [foo11, foo22, foo33] = foo;
console.log(foo11); // abc
console.log(foo1);  // abc


// 2.三元运算符
var number = 10;
var result = number > 10 ? "大于10" : "小于10";
console.log(result);

// 3.in 运算符 指定的属性是否在当前对象
//对于数组 下标算是一个属性
var array = new Array("A", "B", "C");
var str = "A";
if (0 in array) {
    console.log(true);
}
if("length" in array){console.log("length");}

// 4.判断所指定的对象是否是某一个类型
var str1 = new String("123");
console.log(str1 instanceof String);
console.log(typeof(str1));

