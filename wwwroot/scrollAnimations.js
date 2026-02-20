window.observeTimeline = () => {

    // Use both selectors for compatibility
    const items = document.querySelectorAll('.experience__item, .timeline-item');

    const observer = new IntersectionObserver(entries => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('show');
            }
        });
    }, {
        threshold: 0.2
    });

    items.forEach(item => {
        observer.observe(item);
    });
};

window.observeSkills = () => {

    // Use both selectors for compatibility
    const cards = document.querySelectorAll('.skills__card, .skill-card');

    const observer = new IntersectionObserver(entries => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('show');
            }
        });
    }, {
        threshold: 0.2
    });

    cards.forEach(card => {
        observer.observe(card);
    });
};

window.observeProjects = () => {

    // Use both selectors for compatibility
    const cards = document.querySelectorAll('.projects__card, .project-card');

    const observer = new IntersectionObserver(entries => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('show');
            }
        });
    }, {
        threshold: 0.2
    });

    cards.forEach(card => {
        observer.observe(card);
    });
};

window.observeContact = () => {

    // Use both selectors for compatibility
    const items = document.querySelectorAll('.contact-card, .contact__container');

    const observer = new IntersectionObserver(entries => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('show');
            }
        });
    }, { threshold: 0.2 });

    items.forEach(item => observer.observe(item));
};
