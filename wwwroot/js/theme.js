(function () {
    'use strict';

    // Check if theme utilities are already defined
    if (window.themeUtils) {
        return;
    }

    const getStoredTheme = () => localStorage.getItem('theme');

    const getPreferredTheme = () => {
        const storedTheme = getStoredTheme();
        if (storedTheme) return storedTheme;
        return window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light';
    };

    const setTheme = (theme) => {
        document.documentElement.setAttribute('data-bs-theme', theme);
    };

    // Initialize theme
    setTheme(getPreferredTheme());

    // Listen for system theme changes
    const mediaQuery = window.matchMedia('(prefers-color-scheme: dark)');
    const handleThemeChange = () => {
        const storedTheme = getStoredTheme();
        if (storedTheme !== 'light' && storedTheme !== 'dark') {
            setTheme(getPreferredTheme());
        }
    };

    mediaQuery.addEventListener('change', handleThemeChange);

    // Expose utilities globally if needed (optional)
    window.themeUtils = {
        getStoredTheme,
        getPreferredTheme,
        setTheme
    };
})();