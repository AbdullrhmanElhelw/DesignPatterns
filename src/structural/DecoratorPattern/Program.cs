using DecoratorPattern;

var handler = new Handler();

var loggingDecorator = new LoggingDecorator(handler);

var authDecorator = new AuthDecorator(loggingDecorator);

var chachingDecorator = new ChachingDecorator(authDecorator);

chachingDecorator.Handle();