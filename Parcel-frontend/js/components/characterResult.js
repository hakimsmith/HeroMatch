export default function CharacterResult(characters, aesthetic){
    characters.sort(function(a,b){
        return a.aesthetic - b.aesthetic
    })
    return `
   <div class = "char-results">

    ${characters.map(character =>{

        if(character.aesthetic == aesthetic)
        return `
        <div class= "char-single-result">
        <a href= "${character.characterUrl}" target="_blank">
        <img src=${character.image}>            
        <p>${character.name}</p>
        </a>

        </div>
        `
        if(character.aesthetic != aesthetic)
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
   <button value='1' class="allChar">View All Characters</button>
    `
}