function runCubeSum(input) {

    let inputArray = input.split('\n')
    if (inputArray.length < 3) alert('Texto de entrada inválido')
    runBucketSum(inputArray);

}
function log_info(text) {
    console.log(text);
    if (document) {
        document.querySelector('#error').innerText = '';
        document.querySelector('#output').innerText +='';
        document.querySelector('#output').innerText += text + '\n';
    }
}

function runBucketSum(dataArray) {

    $.ajax({
        type: "POST",
        url: 'Home/GetCubeSum',
        data: {
            data: dataArray,
        }
    }).done(function (msg) {
        log_info(msg);
    });
}