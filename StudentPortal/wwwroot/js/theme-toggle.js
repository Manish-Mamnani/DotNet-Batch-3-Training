// Dark Mode Theme Toggle
(function() {
    const html = document.documentElement;
    const themeToggleBtn = document.getElementById('themeToggle');
    const themeIcon = document.querySelector('.theme-icon');
    
    // Check for saved theme preference or default to 'light'
    const currentTheme = localStorage.getItem('theme') || 'light';
    
    // Apply saved theme on page load
    html.setAttribute('data-bs-theme', currentTheme);
    updateThemeIcon(currentTheme);
    
    // Theme toggle button click handler
    themeToggleBtn.addEventListener('click', function() {
        const theme = html.getAttribute('data-bs-theme');
        const newTheme = theme === 'light' ? 'dark' : 'light';
        
        // Update HTML attribute
        html.setAttribute('data-bs-theme', newTheme);
        
        // Save preference to localStorage
        localStorage.setItem('theme', newTheme);
        
        // Update icon
        updateThemeIcon(newTheme);
    });
    
    function updateThemeIcon(theme) {
        if (theme === 'dark') {
            themeIcon.textContent = '☀️'; // Sun icon for switching to light
            themeToggleBtn.title = 'Switch to Light Mode';
        } else {
            themeIcon.textContent = '🌙'; // Moon icon for switching to dark
            themeToggleBtn.title = 'Switch to Dark Mode';
        }
    }
})();
