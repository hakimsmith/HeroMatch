export default function CharacterResult(characters, aesthetic){
    characters.sort(function(a,b){
        if(b.aesthetic == aesthetic){
            return 1
        }
        return a.aesthetic - b.aesthetic
    })
    console.log(characters);
    return `
   <div class = "char-results">
    ${characters.map(character =>{
        if(character.aesthetic == aesthetic && characters.indexOf(character) == 0)
        return `
        <div class= "char-single-result">
        <a href= "${character.characterUrl}" target="_blank">
        <img src=${character.image}>            
        <h3 class='name'>${character.name}</h3>
        </a>

        </div>
        `
        else
        return `
        <div class= "char-single-result">
        <a href= "${character.characterUrl}" target="_blank">
        <img src=${character.smallImage}>            
        <p>${character.name}</p>
        </a>

        </div>
        `   

    }).join("")}
   </div>
   <button value='${characters[0].gameId    }' class="allChar">View All Characters</button>
   <button class='switch-game'>View Similar Characters for Other Game</button>
    `
}