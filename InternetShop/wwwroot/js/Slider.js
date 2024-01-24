window.ScrollSlider = function (slider, current) {
    
    let width = slider.offsetWidth;
    slider.scroll({ left: current * width, behavior: 'smooth' })

  
}

