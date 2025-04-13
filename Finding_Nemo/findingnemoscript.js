const divReferenceForPtag = document.querySelector('#divpara')
const circleImageRef = document.getElementById("startTheFindingNemoGame")
const nemoImageRef = document.createElement('img');
nemoImageRef.src = 'images/nemo.jpg';
nemoImageRef.style.height = '70px';
nemoImageRef.style.width = '70px';

const wrongImageRef = document.createElement('img');
wrongImageRef.src = 'images/wrongLogo.png'; // You'll need a wrong/cross image
wrongImageRef.style.height = '70px';
wrongImageRef.style.width = '70px';

const startTheFindingNemoGame = () => {
    var numberOfBlocks = parseInt(prompt("Enter Number of Blocks: "))
    console.log(numberOfBlocks)
    if (numberOfBlocks != 0) {
        const numberOfNemoFishToBeGuessed = Math.floor((Math.random() * numberOfBlocks) + 1)
        console.log("Nemo is at position: " + numberOfNemoFishToBeGuessed);
        let numberOfAttempts = 0;
        alert("Find Nemo in 5 attempts or less! Best Of Luck!");
        divReferenceForPtag.innerHTML = '';
        for (i = 1; i <= numberOfBlocks; i++) {
            const bubbleBlock = document.createElement('div');
            bubbleBlock.className = 'bubble-block';
            bubbleBlock.dataset.position = i;
            bubbleBlock.classList.add("paraclass")

            // Add blue circle image
            const bubbleImg = document.createElement('img');
            bubbleImg.src = 'images/circle.png'; // Your blue circle image
            bubbleImg.style.height = '70px';
            bubbleImg.style.width = '70px';
            bubbleBlock.appendChild(bubbleImg);

            divReferenceForPtag.appendChild(bubbleBlock);
        }

        divReferenceForPtag.addEventListener('click', (e) => {
            const bubbleBlock = e.target.closest('.bubble-block');
            if (!bubbleBlock || numberOfAttempts >= 5) return;

            const position = parseInt(bubbleBlock.dataset.position);
            numberOfAttempts++;
            if (position === numberOfNemoFishToBeGuessed) {
                // Found Nemo!
                bubbleBlock.innerHTML = '';
                bubbleBlock.appendChild(nemoImageRef.cloneNode());
                bubbleBlock.style.backgroundColor = 'rgba(30, 231, 30, 0.5)';
                bubbleBlock.style.height = '50px';
                bubbleBlock.style.width = '50px';
                // Show congratulations
                const congrats = document.createElement('div');
                congrats.id = 'congrats';
                congrats.innerHTML = `
                    <h1>Congratulations, You Won!!</h1>
                    <h2>Attempts Required to Win: ${numberOfAttempts}</h2>
                `;
                document.body.appendChild(congrats);

                // Disable further clicks
                numberOfAttempts = 5;
            } else {
                // Wrong guess - show cross/wrong image
                bubbleBlock.innerHTML = '';
                bubbleBlock.appendChild(wrongImageRef.cloneNode());
                bubbleBlock.style.backgroundColor = 'rgba(228, 51, 51, 0.5)';

                if (numberOfAttempts === 5) {
                    alert("You're out of attempts! Nemo was hiding in block " + numberOfNemoFishToBeGuessed);
                }
            }
        });
    } else {
        alert("Please enter a number between 10 and 30!");
        startTheFindingNemoGame();
    }
}

startTheFindingNemoGame();