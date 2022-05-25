console.log('Hello Node');

// Es6 allows us to create modules 
// moduale is a reusable code
// Specify it with imports and exports

function gretting(name){
    return `hi my name is ${name}`
}
module.exports = gretting