const fs = require('fs');

// fs.readFile('word_list.txt', 'utf-8', function(err, data){
//     if (err) throw err;

//     const repalcedValue = data.replaceAll(' ', ',');

//     fs.writeFile('new_word_list.txt', repalcedValue, 'utf-8', function(err){
//         if (err) throw err;
//         console.log('Done')
//     })
// })

const string = fs.readFileSync('word_list.txt', 'utf-8');

const array = string.split(",");

console.log(array)