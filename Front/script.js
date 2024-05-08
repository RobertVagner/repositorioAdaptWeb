function verificarTriangulo() {
    var lado1 = parseInt(document.getElementById('side1').value);
    var lado2 = parseInt(document.getElementById('side2').value);
    var lado3 = parseInt(document.getElementById('side3').value);

    if (lado1 > 0 && lado2 > 0 && lado3 > 0) {
        fetch(`/api/triangulos?lado1=${lado1}&lado2=${lado2}&lado3=${lado3}`)
            .then(response => response.json())
            .then(data => {
                var resultado = document.getElementById('resultado');
                resultado.innerText = data.message; // Exibe a mensagem de resultado no elemento
            })
            .catch(error => {
                console.error('Erro ao verificar o triângulo:', error);
            });
    } else {
        alert('Por favor, digite valores válidos para os lados do triângulo.');
    }
}
