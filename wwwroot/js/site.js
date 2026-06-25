// Nav: add shadow on scroll + back-to-top visibility
const backToTop = document.getElementById('backToTop');
let scrollStopTimer = null;

window.addEventListener('scroll', () => {
    document.getElementById('mainNav')?.classList.toggle('scrolled', window.scrollY > 20);

    if (backToTop) {
        const past = window.scrollY > 300;
        backToTop.classList.toggle('visible', past);
        backToTop.classList.remove('idle');

        clearTimeout(scrollStopTimer);
        if (past) {
            scrollStopTimer = setTimeout(() => backToTop.classList.add('idle'), 800);
        }
    }
});

// Smooth active nav link highlighting based on scroll position
const sections = document.querySelectorAll('section[id]');
const navLinks = document.querySelectorAll('.site-nav .nav-link');

const observer = new IntersectionObserver((entries) => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            navLinks.forEach(link => {
                link.classList.toggle('active', link.getAttribute('href') === '#' + entry.target.id);
            });
        }
    });
}, { rootMargin: '-40% 0px -55% 0px' });

sections.forEach(s => observer.observe(s));

// Close mobile menu on nav link click
document.querySelectorAll('.site-nav .nav-link').forEach(link => {
    link.addEventListener('click', () => {
        const collapse = document.getElementById('navMenu');
        if (collapse?.classList.contains('show')) {
            bootstrap.Collapse.getInstance(collapse)?.hide();
        }
    });
});
