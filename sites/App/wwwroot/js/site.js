const timeElements = document.querySelectorAll(".time")
const format = new Intl.DateTimeFormat("en-se", {
    year: "numeric", month: "numeric", day: "numeric",
    hour: "numeric", minute: "numeric", second: "numeric"
})


window.addEventListener("load", () => {
    timeElements.forEach(element => {
        setInterval(() => {
            element.innerHTML = format.format(new Date()).replace(",", "")
        }, 499)
    })
})